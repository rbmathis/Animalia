using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Legatus;

/// <summary>
/// Abstract class for Legatus (genus).
/// NCBI TaxId: 478630
/// </summary>
public abstract class Legatus : Tyrannidae, ILegatus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Legatus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 478630;

    /// <inheritdoc />
    public virtual string GenusName => "Legatus";

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
