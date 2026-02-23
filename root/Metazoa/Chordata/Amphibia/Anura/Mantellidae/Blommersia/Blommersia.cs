using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Mantellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Mantellidae.Blommersia;

/// <summary>
/// Abstract class for Blommersia (genus).
/// NCBI TaxId: 403234
/// </summary>
public abstract class Blommersia : Mantellidae, IBlommersia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Blommersia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 403234;

    /// <inheritdoc />
    public virtual string GenusName => "Blommersia";

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
