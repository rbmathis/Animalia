using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Characidae_incertae_sedis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Characidae_incertae_sedis.Schultzites;

/// <summary>
/// Abstract class for Schultzites (genus).
/// NCBI TaxId: 2608223
/// </summary>
public abstract class Schultzites : Characidae_incertae_sedis, ISchultzites
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Schultzites";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2608223;

    /// <inheritdoc />
    public virtual string GenusName => "Schultzites";

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
