using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Labeoninae_incertae_sedis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Labeoninae_incertae_sedis.Schismatorhynchos;

/// <summary>
/// Abstract class for Schismatorhynchos (genus).
/// NCBI TaxId: 643447
/// </summary>
public abstract class Schismatorhynchos : Labeoninae_incertae_sedis, ISchismatorhynchos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Schismatorhynchos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 643447;

    /// <inheritdoc />
    public virtual string GenusName => "Schismatorhynchos";

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
