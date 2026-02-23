using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae.Parapimelodus;

/// <summary>
/// Abstract class for Parapimelodus (genus).
/// NCBI TaxId: 462337
/// </summary>
public abstract class Parapimelodus : Pimelodidae, IParapimelodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parapimelodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 462337;

    /// <inheritdoc />
    public virtual string GenusName => "Parapimelodus";

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
