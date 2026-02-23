using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Phylloscopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Phylloscopidae.Rhadina;

/// <summary>
/// Abstract class for Rhadina (genus).
/// NCBI TaxId: 2585817
/// </summary>
public abstract class Rhadina : Phylloscopidae, IRhadina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhadina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2585817;

    /// <inheritdoc />
    public virtual string GenusName => "Rhadina";

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
