using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Typhlonectidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Typhlonectidae.Typhlonectes;

/// <summary>
/// Abstract class for Typhlonectes (genus).
/// NCBI TaxId: 8455
/// </summary>
public abstract class Typhlonectes : Typhlonectidae, ITyphlonectes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Typhlonectes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8455;

    /// <inheritdoc />
    public virtual string GenusName => "Typhlonectes";

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
