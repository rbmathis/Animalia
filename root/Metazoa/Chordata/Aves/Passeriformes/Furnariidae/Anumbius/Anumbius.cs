using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Anumbius;

/// <summary>
/// Abstract class for Anumbius (genus).
/// NCBI TaxId: 183170
/// </summary>
public abstract class Anumbius : Furnariidae, IAnumbius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anumbius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 183170;

    /// <inheritdoc />
    public virtual string GenusName => "Anumbius";

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
