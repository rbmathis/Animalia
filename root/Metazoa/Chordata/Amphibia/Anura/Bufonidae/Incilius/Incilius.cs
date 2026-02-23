using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Incilius;

/// <summary>
/// Abstract class for Incilius (genus).
/// NCBI TaxId: 651656
/// </summary>
public abstract class Incilius : Bufonidae, IIncilius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Incilius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 651656;

    /// <inheritdoc />
    public virtual string GenusName => "Incilius";

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
