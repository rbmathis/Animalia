using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae.Betancurichthys;

/// <summary>
/// Abstract class for Betancurichthys (genus).
/// NCBI TaxId: 3363393
/// </summary>
public abstract class Betancurichthys : Ariidae, IBetancurichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Betancurichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3363393;

    /// <inheritdoc />
    public virtual string GenusName => "Betancurichthys";

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
