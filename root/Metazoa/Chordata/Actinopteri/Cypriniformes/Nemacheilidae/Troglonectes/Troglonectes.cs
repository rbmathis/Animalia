using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Troglonectes;

/// <summary>
/// Abstract class for Troglonectes (genus).
/// NCBI TaxId: 2853668
/// </summary>
public abstract class Troglonectes : Nemacheilidae, ITroglonectes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Troglonectes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2853668;

    /// <inheritdoc />
    public virtual string GenusName => "Troglonectes";

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
