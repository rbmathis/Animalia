using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Osteoglossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Osteoglossidae.Osteoglossum;

/// <summary>
/// Abstract class for Osteoglossum (genus).
/// NCBI TaxId: 27724
/// </summary>
public abstract class Osteoglossum : Osteoglossidae, IOsteoglossum
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Osteoglossum";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27724;

    /// <inheritdoc />
    public virtual string GenusName => "Osteoglossum";

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
