using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae.Rubigula;

/// <summary>
/// Abstract class for Rubigula (genus).
/// NCBI TaxId: 2895574
/// </summary>
public abstract class Rubigula : Pycnonotidae, IRubigula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rubigula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2895574;

    /// <inheritdoc />
    public virtual string GenusName => "Rubigula";

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
