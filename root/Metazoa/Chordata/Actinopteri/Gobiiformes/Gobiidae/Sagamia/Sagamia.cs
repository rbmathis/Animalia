using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Sagamia;

/// <summary>
/// Abstract class for Sagamia (genus).
/// NCBI TaxId: 764840
/// </summary>
public abstract class Sagamia : Gobiidae, ISagamia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sagamia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 764840;

    /// <inheritdoc />
    public virtual string GenusName => "Sagamia";

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
