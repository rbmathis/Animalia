using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Lophotriccus;

/// <summary>
/// Abstract class for Lophotriccus (genus).
/// NCBI TaxId: 360213
/// </summary>
public abstract class Lophotriccus : Tyrannidae, ILophotriccus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lophotriccus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 360213;

    /// <inheritdoc />
    public virtual string GenusName => "Lophotriccus";

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
