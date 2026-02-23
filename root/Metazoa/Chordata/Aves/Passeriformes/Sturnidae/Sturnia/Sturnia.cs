using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae.Sturnia;

/// <summary>
/// Abstract class for Sturnia (genus).
/// NCBI TaxId: 2282479
/// </summary>
public abstract class Sturnia : Sturnidae, ISturnia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sturnia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2282479;

    /// <inheritdoc />
    public virtual string GenusName => "Sturnia";

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
