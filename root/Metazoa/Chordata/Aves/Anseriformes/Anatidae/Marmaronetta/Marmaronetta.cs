using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Marmaronetta;

/// <summary>
/// Abstract class for Marmaronetta (genus).
/// NCBI TaxId: 75874
/// </summary>
public abstract class Marmaronetta : Anatidae, IMarmaronetta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Marmaronetta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 75874;

    /// <inheritdoc />
    public virtual string GenusName => "Marmaronetta";

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
