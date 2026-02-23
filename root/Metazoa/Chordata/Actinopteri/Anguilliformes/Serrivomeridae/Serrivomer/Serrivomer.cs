using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Serrivomeridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Serrivomeridae.Serrivomer;

/// <summary>
/// Abstract class for Serrivomer (genus).
/// NCBI TaxId: 182439
/// </summary>
public abstract class Serrivomer : Serrivomeridae, ISerrivomer
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Serrivomer";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 182439;

    /// <inheritdoc />
    public virtual string GenusName => "Serrivomer";

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
