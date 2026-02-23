using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Coelonotus;

/// <summary>
/// Abstract class for Coelonotus (genus).
/// NCBI TaxId: 1821182
/// </summary>
public abstract class Coelonotus : Syngnathidae, ICoelonotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Coelonotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1821182;

    /// <inheritdoc />
    public virtual string GenusName => "Coelonotus";

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
