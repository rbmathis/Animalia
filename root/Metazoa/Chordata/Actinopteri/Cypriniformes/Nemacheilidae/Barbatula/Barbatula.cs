using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Barbatula;

/// <summary>
/// Abstract class for Barbatula (genus).
/// NCBI TaxId: 160394
/// </summary>
public abstract class Barbatula : Nemacheilidae, IBarbatula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Barbatula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 160394;

    /// <inheritdoc />
    public virtual string GenusName => "Barbatula";

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
