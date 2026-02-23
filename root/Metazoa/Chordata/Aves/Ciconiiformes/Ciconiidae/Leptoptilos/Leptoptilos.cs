using AnimalKingdom.root.Metazoa.Chordata.Aves.Ciconiiformes.Ciconiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Ciconiiformes.Ciconiidae.Leptoptilos;

/// <summary>
/// Abstract class for Leptoptilos (genus).
/// NCBI TaxId: 33588
/// </summary>
public abstract class Leptoptilos : Ciconiidae, ILeptoptilos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptoptilos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 33588;

    /// <inheritdoc />
    public virtual string GenusName => "Leptoptilos";

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
