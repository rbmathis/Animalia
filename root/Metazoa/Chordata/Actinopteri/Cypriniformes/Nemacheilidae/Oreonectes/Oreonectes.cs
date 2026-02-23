using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Oreonectes;

/// <summary>
/// Abstract class for Oreonectes (genus).
/// NCBI TaxId: 341094
/// </summary>
public abstract class Oreonectes : Nemacheilidae, IOreonectes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oreonectes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 341094;

    /// <inheritdoc />
    public virtual string GenusName => "Oreonectes";

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
