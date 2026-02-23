using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Sciaenops;

/// <summary>
/// Abstract class for Sciaenops (genus).
/// NCBI TaxId: 76339
/// </summary>
public abstract class Sciaenops : Sciaenidae, ISciaenops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sciaenops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 76339;

    /// <inheritdoc />
    public virtual string GenusName => "Sciaenops";

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
