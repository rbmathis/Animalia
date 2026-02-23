using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Synanceiidae.Synanceiidae_incertae_sedis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Synanceiidae.Synanceiidae_incertae_sedis.Erosa;

/// <summary>
/// Abstract class for Erosa (genus).
/// NCBI TaxId: 2202285
/// </summary>
public abstract class Erosa : Synanceiidae_incertae_sedis, IErosa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Erosa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2202285;

    /// <inheritdoc />
    public virtual string GenusName => "Erosa";

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
