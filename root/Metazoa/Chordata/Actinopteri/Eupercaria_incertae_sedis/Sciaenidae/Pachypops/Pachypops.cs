using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Pachypops;

/// <summary>
/// Abstract class for Pachypops (genus).
/// NCBI TaxId: 1170315
/// </summary>
public abstract class Pachypops : Sciaenidae, IPachypops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pachypops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1170315;

    /// <inheritdoc />
    public virtual string GenusName => "Pachypops";

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
