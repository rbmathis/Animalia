using AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Ranacephala;

/// <summary>
/// Abstract class for Ranacephala (genus).
/// NCBI TaxId: 3145185
/// </summary>
public abstract class Ranacephala : Chelidae, IRanacephala
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ranacephala";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3145185;

    /// <inheritdoc />
    public virtual string GenusName => "Ranacephala";

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
