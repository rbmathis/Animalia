using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Cheimarrichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Cheimarrichthyidae.Cheimarrichthys;

/// <summary>
/// Abstract class for Cheimarrichthys (genus).
/// NCBI TaxId: 206138
/// </summary>
public abstract class Cheimarrichthys : Cheimarrichthyidae, ICheimarrichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cheimarrichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 206138;

    /// <inheritdoc />
    public virtual string GenusName => "Cheimarrichthys";

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
