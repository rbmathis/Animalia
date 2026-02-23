using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Labeoninae_incertae_sedis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Labeoninae_incertae_sedis.Sinilabeo;

/// <summary>
/// Abstract class for Sinilabeo (genus).
/// NCBI TaxId: 369624
/// </summary>
public abstract class Sinilabeo : Labeoninae_incertae_sedis, ISinilabeo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sinilabeo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 369624;

    /// <inheritdoc />
    public virtual string GenusName => "Sinilabeo";

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
