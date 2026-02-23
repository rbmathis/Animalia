using AnimalKingdom.root.Metazoa.Chordata.Testudines.Podocnemididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Podocnemididae.Podocnemis;

/// <summary>
/// Abstract class for Podocnemis (genus).
/// NCBI TaxId: 44505
/// </summary>
public abstract class Podocnemis : Podocnemididae, IPodocnemis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Podocnemis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 44505;

    /// <inheritdoc />
    public virtual string GenusName => "Podocnemis";

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
