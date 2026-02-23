using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Eurylaimidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Eurylaimidae.Eurylaimus;

/// <summary>
/// Abstract class for Eurylaimus (genus).
/// NCBI TaxId: 239375
/// </summary>
public abstract class Eurylaimus : Eurylaimidae, IEurylaimus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eurylaimus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 239375;

    /// <inheritdoc />
    public virtual string GenusName => "Eurylaimus";

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
