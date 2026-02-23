using AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae.Carpococcyx;

/// <summary>
/// Abstract class for Carpococcyx (genus).
/// NCBI TaxId: 8942
/// </summary>
public abstract class Carpococcyx : Cuculidae, ICarpococcyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Carpococcyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8942;

    /// <inheritdoc />
    public virtual string GenusName => "Carpococcyx";

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
