using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zaproridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zaproridae.Zaprora;

/// <summary>
/// Abstract class for Zaprora (genus).
/// NCBI TaxId: 320589
/// </summary>
public abstract class Zaprora : Zaproridae, IZaprora
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zaprora";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 320589;

    /// <inheritdoc />
    public virtual string GenusName => "Zaprora";

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
