using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Aulopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Aulopidae.Latropiscis;

/// <summary>
/// Abstract class for Latropiscis (genus).
/// NCBI TaxId: 1266828
/// </summary>
public abstract class Latropiscis : Aulopidae, ILatropiscis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Latropiscis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1266828;

    /// <inheritdoc />
    public virtual string GenusName => "Latropiscis";

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
