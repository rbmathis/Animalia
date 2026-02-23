using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Coturnicops;

/// <summary>
/// Abstract class for Coturnicops (genus).
/// NCBI TaxId: 302534
/// </summary>
public abstract class Coturnicops : Rallidae, ICoturnicops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Coturnicops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 302534;

    /// <inheritdoc />
    public virtual string GenusName => "Coturnicops";

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
