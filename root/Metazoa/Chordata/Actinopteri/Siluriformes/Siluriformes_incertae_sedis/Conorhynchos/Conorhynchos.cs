using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Siluriformes_incertae_sedis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Siluriformes_incertae_sedis.Conorhynchos;

/// <summary>
/// Abstract class for Conorhynchos (genus).
/// NCBI TaxId: 390401
/// </summary>
public abstract class Conorhynchos : Siluriformes_incertae_sedis, IConorhynchos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Conorhynchos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 390401;

    /// <inheritdoc />
    public virtual string GenusName => "Conorhynchos";

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
