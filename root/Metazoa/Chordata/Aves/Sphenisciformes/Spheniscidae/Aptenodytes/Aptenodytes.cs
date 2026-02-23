using AnimalKingdom.root.Metazoa.Chordata.Aves.Sphenisciformes.Spheniscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Sphenisciformes.Spheniscidae.Aptenodytes;

/// <summary>
/// Abstract class for Aptenodytes (genus).
/// NCBI TaxId: 9232
/// </summary>
public abstract class Aptenodytes : Spheniscidae, IAptenodytes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aptenodytes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9232;

    /// <inheritdoc />
    public virtual string GenusName => "Aptenodytes";

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
