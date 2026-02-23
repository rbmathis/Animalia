using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Ogcocephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Ogcocephalidae.Ogcocephalus;

/// <summary>
/// Abstract class for Ogcocephalus (genus).
/// NCBI TaxId: 390355
/// </summary>
public abstract class Ogcocephalus : Ogcocephalidae, IOgcocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ogcocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 390355;

    /// <inheritdoc />
    public virtual string GenusName => "Ogcocephalus";

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
