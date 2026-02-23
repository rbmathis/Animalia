using AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Cyclanorbis;

/// <summary>
/// Abstract class for Cyclanorbis (genus).
/// NCBI TaxId: 227467
/// </summary>
public abstract class Cyclanorbis : Trionychidae, ICyclanorbis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cyclanorbis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 227467;

    /// <inheritdoc />
    public virtual string GenusName => "Cyclanorbis";

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
