using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae.Cephalopterus;

/// <summary>
/// Abstract class for Cephalopterus (genus).
/// NCBI TaxId: 114275
/// </summary>
public abstract class Cephalopterus : Cotingidae, ICephalopterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cephalopterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 114275;

    /// <inheritdoc />
    public virtual string GenusName => "Cephalopterus";

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
