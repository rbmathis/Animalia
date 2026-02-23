using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Clavelinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Clavelinidae.Clavelina;

/// <summary>
/// Abstract class for Clavelina (genus).
/// NCBI TaxId: 159416
/// </summary>
public abstract class Clavelina : Clavelinidae, IClavelina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Clavelina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 159416;

    /// <inheritdoc />
    public virtual string GenusName => "Clavelina";

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
