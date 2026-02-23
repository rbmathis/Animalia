using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Cyclopsitta;

/// <summary>
/// Abstract class for Cyclopsitta (genus).
/// NCBI TaxId: 503984
/// </summary>
public abstract class Cyclopsitta : Psittacidae, ICyclopsitta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cyclopsitta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 503984;

    /// <inheritdoc />
    public virtual string GenusName => "Cyclopsitta";

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
