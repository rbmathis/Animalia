using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Chrysolampis;

/// <summary>
/// Abstract class for Chrysolampis (genus).
/// NCBI TaxId: 472794
/// </summary>
public abstract class Chrysolampis : Trochilidae, IChrysolampis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chrysolampis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 472794;

    /// <inheritdoc />
    public virtual string GenusName => "Chrysolampis";

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
