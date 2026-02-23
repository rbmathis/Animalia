using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Amblycipitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Amblycipitidae.Amblyceps;

/// <summary>
/// Abstract class for Amblyceps (genus).
/// NCBI TaxId: 337633
/// </summary>
public abstract class Amblyceps : Amblycipitidae, IAmblyceps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amblyceps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 337633;

    /// <inheritdoc />
    public virtual string GenusName => "Amblyceps";

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
