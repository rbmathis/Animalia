using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Ambassidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Ambassidae.Denariusa;

/// <summary>
/// Abstract class for Denariusa (genus).
/// NCBI TaxId: 490319
/// </summary>
public abstract class Denariusa : Ambassidae, IDenariusa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Denariusa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 490319;

    /// <inheritdoc />
    public virtual string GenusName => "Denariusa";

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
