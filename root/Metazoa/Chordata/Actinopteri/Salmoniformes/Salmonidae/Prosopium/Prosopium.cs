using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Prosopium;

/// <summary>
/// Abstract class for Prosopium (genus).
/// NCBI TaxId: 36182
/// </summary>
public abstract class Prosopium : Salmonidae, IProsopium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Prosopium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36182;

    /// <inheritdoc />
    public virtual string GenusName => "Prosopium";

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
