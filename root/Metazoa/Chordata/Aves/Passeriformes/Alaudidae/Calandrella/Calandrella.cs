using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae.Calandrella;

/// <summary>
/// Abstract class for Calandrella (genus).
/// NCBI TaxId: 215309
/// </summary>
public abstract class Calandrella : Alaudidae, ICalandrella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Calandrella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 215309;

    /// <inheritdoc />
    public virtual string GenusName => "Calandrella";

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
