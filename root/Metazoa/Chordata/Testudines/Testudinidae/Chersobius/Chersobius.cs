using AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Chersobius;

/// <summary>
/// Abstract class for Chersobius (genus).
/// NCBI TaxId: 2267536
/// </summary>
public abstract class Chersobius : Testudinidae, IChersobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chersobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2267536;

    /// <inheritdoc />
    public virtual string GenusName => "Chersobius";

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
