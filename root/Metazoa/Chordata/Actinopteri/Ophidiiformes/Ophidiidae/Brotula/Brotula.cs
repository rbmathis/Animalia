using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Brotula;

/// <summary>
/// Abstract class for Brotula (genus).
/// NCBI TaxId: 417944
/// </summary>
public abstract class Brotula : Ophidiidae, IBrotula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brotula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 417944;

    /// <inheritdoc />
    public virtual string GenusName => "Brotula";

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
