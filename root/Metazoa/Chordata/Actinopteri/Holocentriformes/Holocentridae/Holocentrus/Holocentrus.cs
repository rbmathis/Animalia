using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Holocentriformes.Holocentridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Holocentriformes.Holocentridae.Holocentrus;

/// <summary>
/// Abstract class for Holocentrus (genus).
/// NCBI TaxId: 94925
/// </summary>
public abstract class Holocentrus : Holocentridae, IHolocentrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Holocentrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 94925;

    /// <inheritdoc />
    public virtual string GenusName => "Holocentrus";

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
