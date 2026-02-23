using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Platylophus;

/// <summary>
/// Abstract class for Platylophus (genus).
/// NCBI TaxId: 205796
/// </summary>
public abstract class Platylophus : Corvidae, IPlatylophus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Platylophus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 205796;

    /// <inheritdoc />
    public virtual string GenusName => "Platylophus";

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
