using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Polystictus;

/// <summary>
/// Abstract class for Polystictus (genus).
/// NCBI TaxId: 478636
/// </summary>
public abstract class Polystictus : Tyrannidae, IPolystictus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Polystictus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 478636;

    /// <inheritdoc />
    public virtual string GenusName => "Polystictus";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
