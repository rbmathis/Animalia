using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae.Oxydoras;

/// <summary>
/// Abstract class for Oxydoras (genus).
/// NCBI TaxId: 238636
/// </summary>
public abstract class Oxydoras : Doradidae, IOxydoras
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oxydoras";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 238636;

    /// <inheritdoc />
    public virtual string GenusName => "Oxydoras";

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
