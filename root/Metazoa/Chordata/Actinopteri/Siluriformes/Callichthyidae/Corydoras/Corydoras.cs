using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Callichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Callichthyidae.Corydoras;

/// <summary>
/// Abstract class for Corydoras (genus).
/// NCBI TaxId: 36707
/// </summary>
public abstract class Corydoras : Callichthyidae, ICorydoras
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Corydoras";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36707;

    /// <inheritdoc />
    public virtual string GenusName => "Corydoras";

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
