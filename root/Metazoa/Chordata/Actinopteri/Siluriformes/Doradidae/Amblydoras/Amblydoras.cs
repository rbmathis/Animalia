using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae.Amblydoras;

/// <summary>
/// Abstract class for Amblydoras (genus).
/// NCBI TaxId: 238559
/// </summary>
public abstract class Amblydoras : Doradidae, IAmblydoras
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amblydoras";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 238559;

    /// <inheritdoc />
    public virtual string GenusName => "Amblydoras";

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
