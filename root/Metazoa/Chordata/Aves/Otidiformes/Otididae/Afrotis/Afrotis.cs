using AnimalKingdom.root.Metazoa.Chordata.Aves.Otidiformes.Otididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Otidiformes.Otididae.Afrotis;

/// <summary>
/// Abstract class for Afrotis (genus).
/// NCBI TaxId: 156153
/// </summary>
public abstract class Afrotis : Otididae, IAfrotis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Afrotis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 156153;

    /// <inheritdoc />
    public virtual string GenusName => "Afrotis";

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
