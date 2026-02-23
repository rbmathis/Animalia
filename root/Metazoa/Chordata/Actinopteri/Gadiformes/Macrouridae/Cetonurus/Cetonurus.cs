using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae.Cetonurus;

/// <summary>
/// Abstract class for Cetonurus (genus).
/// NCBI TaxId: 1443079
/// </summary>
public abstract class Cetonurus : Macrouridae, ICetonurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cetonurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1443079;

    /// <inheritdoc />
    public virtual string GenusName => "Cetonurus";

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
