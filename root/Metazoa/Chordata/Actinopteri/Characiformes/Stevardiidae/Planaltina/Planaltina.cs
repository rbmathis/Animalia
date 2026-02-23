using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Planaltina;

/// <summary>
/// Abstract class for Planaltina (genus).
/// NCBI TaxId: 930374
/// </summary>
public abstract class Planaltina : Stevardiidae, IPlanaltina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Planaltina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 930374;

    /// <inheritdoc />
    public virtual string GenusName => "Planaltina";

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
