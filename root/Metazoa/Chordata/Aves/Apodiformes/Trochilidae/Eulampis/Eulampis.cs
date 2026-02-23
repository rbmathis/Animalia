using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Eulampis;

/// <summary>
/// Abstract class for Eulampis (genus).
/// NCBI TaxId: 190443
/// </summary>
public abstract class Eulampis : Trochilidae, IEulampis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eulampis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 190443;

    /// <inheritdoc />
    public virtual string GenusName => "Eulampis";

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
