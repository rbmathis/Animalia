using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Psophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Psophiidae.Psophia;

/// <summary>
/// Abstract class for Psophia (genus).
/// NCBI TaxId: 54358
/// </summary>
public abstract class Psophia : Psophiidae, IPsophia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Psophia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 54358;

    /// <inheritdoc />
    public virtual string GenusName => "Psophia";

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
