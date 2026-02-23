using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae.Doliornis;

/// <summary>
/// Abstract class for Doliornis (genus).
/// NCBI TaxId: 114296
/// </summary>
public abstract class Doliornis : Cotingidae, IDoliornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Doliornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 114296;

    /// <inheritdoc />
    public virtual string GenusName => "Doliornis";

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
