using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Larimus;

/// <summary>
/// Abstract class for Larimus (genus).
/// NCBI TaxId: 329432
/// </summary>
public abstract class Larimus : Sciaenidae, ILarimus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Larimus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 329432;

    /// <inheritdoc />
    public virtual string GenusName => "Larimus";

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
