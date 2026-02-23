using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Clariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Clariidae.Heterobranchus;

/// <summary>
/// Abstract class for Heterobranchus (genus).
/// NCBI TaxId: 103209
/// </summary>
public abstract class Heterobranchus : Clariidae, IHeterobranchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heterobranchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 103209;

    /// <inheritdoc />
    public virtual string GenusName => "Heterobranchus";

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
