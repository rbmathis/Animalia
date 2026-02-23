using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Pinguipedidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Pinguipedidae.Simipercis;

/// <summary>
/// Abstract class for Simipercis (genus).
/// NCBI TaxId: 2986113
/// </summary>
public abstract class Simipercis : Pinguipedidae, ISimipercis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Simipercis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2986113;

    /// <inheritdoc />
    public virtual string GenusName => "Simipercis";

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
